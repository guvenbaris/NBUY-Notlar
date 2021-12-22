import React, { Component } from "react";
import { connect } from "react-redux";
import {
  UncontrolledDropdown,
  DropdownToggle,
  DropdownMenu,
  DropdownItem,
  NavItem,
  NavLink,
  Badge,
} from "reactstrap";
class CartSummary extends Component {
  renderEmpty() {
    return (
      <NavItem>
        <NavLink>Sepetiniz boş</NavLink>
      </NavItem>
    );
  }
  renderSummary() {
      return(
        <UncontrolledDropdown nav inNavbar>
        <DropdownToggle nav caret>
          Sepetiniz
        </DropdownToggle>
        <DropdownMenu end>
        {
          this.props.cart.map(cartItem=>(
           <DropdownItem key = {cartItem.product.id}><Badge color="success">{cartItem.quantity}</Badge>{cartItem.product.productName}</DropdownItem>
          ))}
          <DropdownItem divider />
          <DropdownItem>Sepete git</DropdownItem>
        </DropdownMenu>
      </UncontrolledDropdown>
      );
  }
  render() {
    return (
      <div>
        {this.props.cart.length > 0 ? this.renderSummary() : this.renderEmpty()}
      </div>
    );
  }
}
function mapStateToProps(state) {
  return {
    cart: state.cartReducer,
  };
}
export default connect(mapStateToProps)(CartSummary);
