import threading
import sys
import time
from pynput import keyboard

class simulator:
    def __init__(self):
        # TODO: configurable control rod speed

        # Config stuff

        # The higher this number is, the earlier you will get positive reactivity.
        self.minimum_rod_worth_for_reactivity = 99.0

        # The amount of time in seconds between model runs
        self.model_inverval = 0.1

        # How much neutron density you need to get thermal power
        self.thermal_power_min_density = 10.00

        # End config stuff

        self.control_rods = 100
        self.reactivity = 0.00
        self.neutron_density = 0.00
        self.thermal_power = 0.00
        self.rod_worth = float(self.control_rods)
        self.adjusted_rod_worth = 0.00
        self.stop_input_i = False
        self.stop_input_k = False
        self.rods_moving = False
        self.minimum_rod_worth_for_reactivity -= self.minimum_rod_worth_for_reactivity*2
        simulator.start_listener(self)
        simulator.run_model(self)

    def run_model(self):
        while True:
            self.reactivity = 0.00
            self.adjusted_rod_worth = 0.00
            self.adjusted_rod_worth -= self.rod_worth*1.5+self.minimum_rod_worth_for_reactivity
            self.reactivity += self.adjusted_rod_worth/2

            # Slowly decrease neutron density if reactivity is negative
            if self.reactivity < 0 and self.neutron_density > 0.00:
                self.neutron_density += self.reactivity/20

            # If we have positive reactivity, we increase neutron density.
            if self.reactivity > 0:
                self.neutron_density += self.reactivity/20

            # If we have enough density, increase thermal power.
            # Also, decrease thermal power if neutron density is negative.
            if self.neutron_density > self.thermal_power_min_density or self.neutron_density < 0 and self.thermal_power > 0:
                self.thermal_power += self.reactivity/4

            # make thermal power 0 if it became negative
            if self.thermal_power < 0:
                self.thermal_power = 0.00

            print(f"reactivity: {self.reactivity} | rod insertion: {self.rod_worth} | neutron density: {self.neutron_density} | Thermal power: {int(self.thermal_power)}MWt")
            time.sleep(self.model_inverval)

    def actually_on_press(self, key):
        print("got a press")
        # exit if it's crtl + c
        if key.char == "\x03":
            sys.exit()
        elif key.char == "k" and self.rods_moving == False:
            self.rods_moving = True
            while True:
                if self.stop_input_i == True:
                    self.stop_input_i = False
                    self.rods_moving = False
                    break
                if self.rod_worth < self.control_rods:
                    self.rod_worth += 0.1
                time.sleep(0.1)
        elif key.char == "i" and self.rods_moving == False:
            self.rods_moving = True
            while True:
                if self.stop_input_k == True:
                    self.stop_input_k = False
                    self.rods_moving = False
                    break
                if self.rod_worth > 0.2:
                    self.rod_worth -= 0.1
                else:
                    self.rod_worth = 0.0
                    self.rods_moving = False
                    break
                time.sleep(0.1)
        elif key.char == "s":
            # Stop the rods from moving anymore
            self.stop_input_k = True
            self.stop_input_i = True

            # Insert rods quickly
            while self.rod_worth < self.control_rods:
                self.rod_worth += 10
                time.sleep(0.2)


    def on_press(self, key):
        # run the actual code in a seperate thread because pynput hates blocking stuff
        threading.Thread(target=lambda: self.actually_on_press(key)).start()

    def on_release(self, key):
        if self.rods_moving == True:
            if key.char == "k":
                self.stop_input_k = True
            elif key.char == "i":
                self.stop_input_i = True

    def start_listener(self):
        listener = keyboard.Listener(
            on_press=self.on_press,
            on_release=self.on_release)
        listener.start()

simulator()
