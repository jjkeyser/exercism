class SpaceAge:

    EARTH_YEAR_IN_SECONDS = 31557600    

    def __init__(self, seconds):
        self.seconds = seconds
        self.age_on_earth = self.seconds / self.EARTH_YEAR_IN_SECONDS

    def on_earth(self):
        return float('{:.2f}'.format(self.age_on_earth))

    def on_mercury(self):
        return float('{:.2f}'.format(self.age_on_earth / 0.2408467))
    
    def on_venus(self):
        return float('{:.2f}'.format(self.age_on_earth / 0.61519726))

    def on_mars(self):
        return float('{:.2f}'.format(self.age_on_earth / 1.8808158))

    def on_jupiter(self):
        return float('{:.2f}'.format(self.age_on_earth / 11.862615))

    def on_saturn(self):
        return float('{:.2f}'.format(self.age_on_earth / 29.447498))

    def on_uranus(self):
        return float('{:.2f}'.format(self.age_on_earth / 84.016846))

    def on_neptune(self):
        return float('{:.2f}'.format(self.age_on_earth / 164.79132))
