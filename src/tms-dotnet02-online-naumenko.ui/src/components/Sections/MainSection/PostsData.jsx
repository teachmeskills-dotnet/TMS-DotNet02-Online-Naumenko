import React, { useState, useEffect } from 'react'

export default function PostsData(props) {
  const [Posts, setPosts] = useState([])

  const getData = () => {
    fetch('https://localhost:5001/posts/')
      .then((res) => res.json())
      .then((res) => {
        setPosts(res);
      })
  }

  if(props.removePost !== null || props.removePost !== 0 || props.removePost !== undefined){
    DeletePost(props.removePost);
  }

  async function DeletePost(id){
    await fetch('https://localhost:5001/posts?id=' + id,{
      method: 'DELETE',
      headers: {'Content-type': 'application/json'},
      credentials: 'include',
    });
    props.refreshPage();
  }

  async function UpdatePost(id){
    await fetch('https://localhost:5001/posts',{
      method: 'PUT',
      headers: {'Content-type': 'application/json'},
      credentials: 'include',
      body: JSON.stringify({
        "id": id,
        "typeId": 1,
        "title": "Lithuanians organise donation drive to buy Bayraktar drone for Ukraine",
        "slug": "lithuanians-organise-donation-drive-to-buy-bayraktar-drone-for-ukraine",
        "content": "Hundreds of Lithuanians are chipping in together to buy an advanced military drone for Ukraine in its war against Russia in a show of solidarity with a fellow former Soviet Union country. Some €3 million have been raised in just three days — out of the €5m needed — largely in small amounts, according to Laisves TV, a Lithuanian internet broadcaster that launched the drive.Before this war started, none of us thought that we would be buying guns. But it's a normal thing now. Something must be done for the world to get better, said Agne Belickaite, 32, who sent €100 as soon as the fundraising launched on Wednesday. I've been donating to buy guns for Ukraine for a while now. And will do so until the victory, she told Reuters, adding she was motivated in part by fears Russia could attack Lithuania. The drone has proven effective in recent years against Russian forces and their allies in conflicts in Syria and Libya, and its purchase is being orchestrated by Lithuania's Ministry of Defence, which plans to sign a letter of intent to buy the craft from Turkey next week. Ukraine has bought more than 20 Bayraktar TB2 armed drones from Turkish company Baykar in recent years and ordered a further 16 on 27 January. That batch was delivered in early March. This is the first case in history when ordinary people raise money to buy something like a Bayraktar. It is unprecedented, it is unbelievable, Beshta Petro, Ukraine's ambassador to Lithuania, told Laisves TV. Most of the heavy weapons that NATO countries have sent to Ukraine so far are Soviet-built arms still in the inventories of eastern European NATO member states, but some have recently started to supply Western howitzers.",
        "excerpt": "Hundreds of Lithuanians are chipping in together to buy an advanced military drone for Ukraine in its war against Russia in a show of solidarity with a fellow former Soviet Union country. Some €3 million have been raised in just three days — out of the €5m needed — largely in small amounts, according to Laisves TV, a Lithuanian internet broadcaster that launched the drive.Before this war started, none of us thought that we would be buying guns. But it's a normal thing now. Something must be done for the world to get better, said Agne Belickaite, 32, who sent €100 as soon as the fundraising launched on Wednesday. I've been donating to buy guns for Ukraine for a while now. And will do so until the victory, she told Reuters, adding she was motivated in part by fears Russia could attack Lithuania.",
        "readingTime": "2 min",
        "date": "2022-04-19T00:00:00",
        "modificationDate": "2022-04-19T00:00:00",
        "postStatusId": 1,
        "userId": 1,
        "fileId": 2
      })
    })
  }

  useEffect(() => {
    getData()
  }, [])

  props.posts(Posts);
  return (
    <>
    </>
  )
}