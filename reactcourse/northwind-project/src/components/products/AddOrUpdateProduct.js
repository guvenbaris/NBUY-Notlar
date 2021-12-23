import React, { useEffect, useState } from "react";
import { connect } from "react-redux";
import {getCategories}  from "../../redux/actions/categoryActions"
import {getProducts, saveProduct}  from "../../redux/actions/productActions"

function AddOrUpdateProduct({
  products,
  categories,
  getProducts,
  getCategories,
  saveProduct,
  history,
  ...props
}) {
  //props.product'ı setProduct fonk. ile set edebilirim.
  const [product, setProduct] = useState({ ...props.product });
  useEffect(() => {
    if (categories.length === 0) {
      getCategories();
      //Eğer linke geldiyse direkt categorileri getirmemiz gerekiyor.
    }
    setProduct({ ...props.product });
  },[props.product]);
  function handleChange(event) {
    const { name, value } = event.target;
    setProduct((previousProduct) => ({
      ...previousProduct,
      [name]: name === "categoryId" ? parseInt(value, 10) : value
    }));
  }
  function handleSave(event) {
    event.preventDefault();
    saveProduct(product).then(() => {
      history.push("/")
    });
  }
  
    //return(Detay Sayfası Gelecek )
  
}
export function getProductById(products,productId){
    let product = products(product=>product.id === productId)||null;
    return product; 
}

function mapStateToProps(state,ownProps){
    const productId = ownProps.match.params.productId
    const product = product && state.productReducer.length > 0
    ? getProductById(state.productReducer,productId)
    : {}
    return {
        product,
        products : state.productReducer,
        categories : state.categoryReducer,
    }
}

const mapDispatchToProps = {
    getCategories,saveProduct
}

export default connect(mapDispatchToProps,mapStateToProps)(AddOrUpdateProduct)