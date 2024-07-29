from Helpers.ProductHelper import ProductHelper

def main():
    # Dosya yolu
    file_path = 'Products.txt'
    
    # Ürünleri dosyadan oluşturma
    try:
        products = ProductHelper.create_item_from_text(file_path)
        
        # Toplam bakiye hesaplama
        total_balance = ProductHelper.get_total_balance(products)
        print(f"Total balance including VAT: {total_balance:.2f}")
    except FileNotFoundError as e:
        print(e)

if __name__ == "__main__":
    main()
