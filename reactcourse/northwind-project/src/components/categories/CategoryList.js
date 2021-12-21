import React, { Component } from "react";
import { connect } from "react-redux";
import { ListGroup, ListGroupItem,Badge } from "reactstrap";
import { bindActionCreators } from "redux";
import * as categoryAction from "../../redux/actions/categoryAction";

class CategoryList extends Component {
  componentDidMount() {
    this.props.actions.getCategories();
  }
  selectCategory = (category) => {
    this.props.actions.changeCategory(category);
  };

  render() {
    return (
      <div>
        <Badge color="warning">Categories</Badge>
        <ListGroup>
          {this.props.categories.map((category) => (
            <ListGroupItem
              key={category.id}
              onClick={() => this.selectCategory(category)}
              active={category.id === this.props.currentCategory.id}
            >
              {category.categoryName}
            </ListGroupItem>
          ))}
        </ListGroup>
      </div>
    );
  }
}
function mapStateToProps(state) {
  return {
    currentCategory: state.changeCategoryReducer,
    categories: state.categoryListReducer,
  };
}

function mapDispatchToProps(dispatch) {
  return {
    actions: {
      getCategories: bindActionCreators(categoryAction.getCategories, dispatch),
      changeCategory: bindActionCreators(
        categoryAction.changeCategory,
        dispatch
      ),
    },
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(CategoryList);
