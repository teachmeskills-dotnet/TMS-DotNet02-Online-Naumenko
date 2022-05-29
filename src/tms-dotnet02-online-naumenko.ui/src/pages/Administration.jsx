import React, {useEffect} from 'react';
import Posts from '../components/Administration/Posts/Posts';

const Administration = () => {
    
    useEffect(() => {
        (
            async() => {
                const response = await fetch('https://localhost:5001/users/user',{
                    method: 'POST',
                    headers: {'Content-type': 'application/json'},
                    //credentials: 'include'
                });
            }
        )();
    });

    return (
        <Posts />
    );
};

export default Administration;