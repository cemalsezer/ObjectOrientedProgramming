from datetime import datetime

class Product:
    def __init__(self, name="Unknown", price=0.0, quantity=1):
        self._name = None
        self._price = None
        self._quantity = None
        
        self.name = name
        self.price = price
        self.quantity = quantity

        # Ürün adını ve mevcut tarihi yazdır
        print(f"Product created: {self.name}")
        print(f"Date: {datetime.now()}")

    @property
    def name(self):
        return self._name

    @name.setter
    def name(self, value):
        if len(value) < 3 or len(value) > 8:
            raise ValueError("Name must be between 3 and 8 characters.")
        self._name = value

    @property
    def price(self):
        return self._price

    @price.setter
    def price(self, value):
        if value < 0:
            raise ValueError("Price must be at least 0.")
        self._price = value

    @property
    def quantity(self):
        return self._quantity

    @quantity.setter
    def quantity(self, value):
        if value < 1:
            raise ValueError("Quantity must be at least 1.")
        self._quantity = value

    def get_total_price(self):
        return self.price * self.quantity

    def __str__(self):
        return (f"Product(name='{self.name}', price={self.price}, quantity={self.quantity}, "
                f"total_price={self.get_total_price()})")