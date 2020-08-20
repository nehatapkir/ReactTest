import React, { Component } from 'react';
import { withRouter } from 'react-router-dom';

export class EmployeeSales extends Component {
    static displayName = EmployeeSales.name;

  constructor (props) {
    super(props);
    this.state = { saleRecords: [], loading: true }; 
    fetch('api/EmployeeSales/EmployeeSalesRecord')
    .then(response => response.json())
    .then(data => {
          this.setState({ saleRecords: data, loading: false });
      });
    }
    
     renderSalesRecordsTable(saleRecords) {
        return (
          <table className='table table-striped'>
            <thead>
              <tr>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Total Sales</th>
                <th>Manager</th>
              </tr>
            </thead>
            <tbody>
                    {saleRecords.map(saleRecord =>
                        <tr key={saleRecord.employee.id}>
                            <td>{saleRecord.employee.firstName}</td>
                            <td>{saleRecord.employee.lastName}</td>
                            <td>{saleRecord.totalSales}</td>
                            <td>{saleRecord.managerName}</td>
                            <td><button onClick={() => this.props.history.push({
                                pathname: '/details',
                                state: { detail: saleRecord }
                            })} > View Details</button></td> 
                        </tr>
              )}
            </tbody>
          </table>
        );
  }

  render () {
    let contents = this.state.loading
        ? <p><em>Loading...</em></p>        
        : this.renderSalesRecordsTable(this.state.saleRecords);

    return (
      <div>
        <h1>Employee Sales Records</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }
}
export default withRouter(EmployeeSales);