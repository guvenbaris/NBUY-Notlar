import React, { Component } from 'react';

class FormDemo1 extends Component {
    state = {userName:'',cityName:''}
    onChangeHandler = (event) =>{
        //this.setState({userName:event.target.value})
        let name = event.target.name;
        let value = event.target.value;
        this.setState({[name]:value})
    }
    onSubmitHandler = (event) =>{
        event.preventDefault();
        alert(this.state.userName);
    }
    render() {
        return (
            <div>
                <form onSubmit={this.onSubmitHandler}>
                    <h3>User Name : </h3>
                    <input name="userName" onChange={this.onChangeHandler} type="text"></input>
                    <h3>User Name is {this.state.userName}</h3>

                    <h3>City Name : </h3>
                    <input name="cityName" onChange={this.onChangeHandler} type="text"></input>
                    <h3>City Name is {this.state.cityName}</h3>
                    <input type = "submit" value ="Save"></input>
                </form>
            </div>
        );
    }
}
export default FormDemo1;