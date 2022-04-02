import React from 'react';
import PostList from '../../Posts/PostList/PostList';
import PostWithBackgroud from '../../Posts/PostWithBackground/PostWithBackground';
import bgimage from '../../Posts/avatar.jpeg';

const MainSection = (props) => {
    return (
        <section className="section-main pt__3">
            <div className="row g__3">
                <div className="col-md-5">
                    <PostWithBackgroud 
                    handleToggle={props.handleToggle} 
                    link={'https://test.test'} 
                    title={'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала'} 
                    date={'Вчера, 21:34'} 
                    views={10} 
                    background={bgimage}
                    height='lg'/>
                </div>
                <div className="col-md-3">
                    <PostList 
                    handleToggle={props.handleToggle} 
                    posts={props.posts}/>
                </div>
                <div className="col-md-4">
                    <div className="row g__3">
                        <div className="col-md-12">
                            <PostWithBackgroud 
                            handleToggle={props.handleToggle} 
                            link={'https://test.test'} 
                            title={'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала'} 
                            date={'Вчера, 21:34'} 
                            views={10} 
                            background={bgimage}
                            height='sm'/>
                        </div>
                        <div className="col-md-12">
                            <PostWithBackgroud 
                            handleToggle={props.handleToggle} 
                            link={'https://test.test'} 
                            title={'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала'} 
                            date={'Вчера, 21:34'} 
                            views={10} 
                            background={bgimage}
                            height='sm'/>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    );
};

export default MainSection;