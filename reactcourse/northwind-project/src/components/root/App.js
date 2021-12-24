import { Container } from "reactstrap";
import Dashboard from "./Dashboard";
import Navi from "../navi/Navi";
import React from 'react';
import { Route, Routes } from "react-router-dom";
import CartDetail from "../cart/CartDetail";
import AddOrUpdateProduct from "../products/AddOrUpdateProduct";
import NotFound from "../common/NotFound";

function App() {
  return (
    <Container>
      <Navi></Navi>
      <Routes>
        <Route path="/" element={<Dashboard/>}></Route>
        <Route path="/product" element={<Dashboard/>} ></Route>
        <Route path="/cart" element={<CartDetail/>} ></Route>
        <Route path="/saveproduct/:productId" element={<AddOrUpdateProduct/>} ></Route>
        <Route path="/saveproduct/" element={<AddOrUpdateProduct/>} ></Route>
        <Route path="*" element={<NotFound/>} ></Route>
      </Routes>
    </Container>
  );
}

export default App;
