import React from 'react'

export default function Buddy({number,name})
{
    return(
        <li className="list-group-item">
            <span className ="badge badge-primary badge-pill">{number}</span>
             {name}
             <button className="btn btn-primary float-right" type="submit">Remove</button>
        </li>
    )
}


