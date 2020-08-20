import React, {   Component  } from "react";

export class Details extends Component {
    render() {
        var details = (this.props.location.state.detail);
        return (
            <div>
                <h1>Employee Details</h1>
                <p>Full Name   : <strong>{details.employee.firstName} {details.employee.lastName}</strong></p>
                <p>Sales count : <strong>{details.totalSales}</strong></p>
                <p>Manager     : <strong>{details.managerName}</strong></p>
           </div>
        );
    }
}
export default Details;