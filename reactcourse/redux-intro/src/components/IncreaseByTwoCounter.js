import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import {connect} from 'react-redux'
import { increaseByTwoCounter } from '../redux/actions/counterActions';

class IncreaseByTwoCounter extends Component {
    render() {
        return (
            <div>
                <button onClick={()=>this.props.dispatch(increaseByTwoCounter())}>
                iki arttır
                </button>
            </div>
        );
    }
}

function mapDispatchToProps(dispatch) {
    return {actions:bindActionCreators(increaseByTwoCounter,dispatch)}
}

export default connect(mapDispatchToProps)(IncreaseByTwoCounter);