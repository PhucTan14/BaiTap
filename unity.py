def stats_cart(cart):
    total_amout , total_quantity = 0,0
    for c in cart.values():
        total_quantity += c['quantity']
        total_amout += c['quantity']*c['price']
    return {
        "total_amount": total_amout,
        "total_quantity": total_quantity
    }