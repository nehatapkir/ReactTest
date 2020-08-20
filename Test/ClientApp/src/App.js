import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { EmployeeSales } from './components/EmployeeSales';
import { Details } from './components/Details';
export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
            <Route exact path='/' component={EmployeeSales} />
            <Route path='/details' component={Details} />    
      </Layout>
    );
  }
}
