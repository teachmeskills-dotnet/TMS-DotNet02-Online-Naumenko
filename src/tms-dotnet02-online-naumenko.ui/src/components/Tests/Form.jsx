import React from 'react';

const Form = () => {
    let empInfo = {
        Title:"test react",
        Slug:"test react",
        Content:"test react",
        Excerpt:"test react",
        Date: "2000-01-01T00:00:00",
        typeId: 1,
        userId: 2
    }
    console.log(empInfo);
    const SendData = () => {
        fetch('posts',{
        method: 'POST',
        headers:{'Content-type':'application/json'},
            body: empInfo
        }).then(r=>r.json()).then(res=>{
        if(res){
            this.setState({message:'New Post is Created Successfully'});
        }
        });
    }
    return (
        <div className='form'>
            <input type="text" id="Title"/>
            <input type="text" id="Slug"/>
            <input type="text" id="Content"/>
            <input type="text" id="Excerpt"/>
            <button onClick={SendData}>Send</button>
        </div>
    );
};

export default Form;