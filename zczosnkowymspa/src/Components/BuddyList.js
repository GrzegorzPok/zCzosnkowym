import React, { Component } from 'react'
import Buddy from './Buddy'

export default class BuddyList extends Component {
    constructor(props)
    {
        super(props);
        this.state = {
            buddys:[
                {id:1,buddyName:"Tomasz Z"},
                {id:2,buddyName:"Jarek K"},
                {id:3,buddyName:"Grzegorz P"},
                {id:4,buddyName:"Łukasz B"},
                {id:5,buddyName:"Encjonariusz"}
            ]
        }        
    }   

    render() {
        return (
            <div>
                <h1>Buddys list</h1>
                <ul className="list-group">
                    {this.state.buddys.map(buddy=>
                        (
                            <Buddy key={buddy.id} number = {buddy.id} name = {buddy.buddyName}/>
                        ))}
                </ul>
            </div>
        )
    }
}
