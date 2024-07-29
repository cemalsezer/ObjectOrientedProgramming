import os
from Models.Product import Product

class ProductHelper:
    @staticmethod
    def create_item_from_text(file_path):
        products = []
        if not os.path.isfile(file_path):
            raise FileNotFoundError("The file does not exist.")
        
        with open(file_path, 'r') as file:
            for line in file:
                parts = line.strip().split(',')
                if len(parts) == 3:
                    name, price_str, quantity_str = parts
                    try:
                        price = float(price_str)
                        quantity = int(quantity_str)
                        product = Product(name, price, quantity)
                        products.append(product)
                    except ValueError:
                        print(f"Skipping invalid line: {line.strip()}")
        
        return products

    @staticmethod
    def get_total_balance(products):
        total_balance = 0
        for product in products:
            total_balance += product.get_total_price()
        
        vat_rate = 0.20
        total_balance_with_vat = total_balance * (1 + vat_rate)
        return total_balance_with_vat
