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
import { bindActionCreators } from "redux";
import * as cartActions from "../../redux/actions/cartActions";
import alertify from "alertifyjs";


class CartSummary extends Component {

  deleteToCart = (product) => {
    this.props.actions.deleteItem(product)
    alertify.warning(product.productName +" sepetten silindi")
  }
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
           <DropdownItem key = {cartItem.product.id}><Badge color="success">{cartItem.quantity}</Badge>{cartItem.product.productName}
           <Badge color="danger" style={{
              marginLeft: '10px',
            }} onClick ={ ()=> this.deleteToCart(cartItem.product)}> - </Badge></DropdownItem>
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

function mapDispatchToProps(dispatch){
  return {
    actions : {
        deleteItem : bindActionCreators(cartActions.removeFromCart,dispatch),
    }
  }
}
export default connect(mapStateToProps,mapDispatchToProps)(CartSummary);
