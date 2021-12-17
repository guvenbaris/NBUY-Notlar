import React, { Component } from 'react';
import { UncontrolledDropdown,
    DropdownToggle,
    DropdownMenu,
    DropdownItem} from "reactstrap";
class CartSummary extends Component {
    render() {
        return (
            <div>
                 <UncontrolledDropdown nav inNavbar>
                <DropdownToggle nav caret>
                  Options - {this.props.deneme.length}
                </DropdownToggle>
                <DropdownMenu right>
                  <DropdownItem>
                    Option 1
                  </DropdownItem>
                  <DropdownItem>
                    Option 2
                  </DropdownItem>
                  <DropdownItem divider />
                  <DropdownItem>
                    Reset
                  </DropdownItem>
                </DropdownMenu>
              </UncontrolledDropdown>
            </div>
        );
    }
}

export default CartSummary;