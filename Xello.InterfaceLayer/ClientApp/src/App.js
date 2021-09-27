import React, { Component } from 'react';
import { Signup } from './components/Signup';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <div>
        <Signup/>
      </div>
    )
  }
}
