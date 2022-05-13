import { useState, useEffect } from "react";
import { Product } from "../../app/models/Product";
import ProductList from "./ProductList";

export default function Catalog() {
    const [products, setProducts] = useState<Product[]>([]); 

  useEffect(() => {
    fetch('http://localhost:5000/api/products')
      .then(Response => Response.json())
      .then(data => setProducts(data))
  }, [])

    return (
        <>
            <ProductList products={products}/>
        </>
        
    )
}