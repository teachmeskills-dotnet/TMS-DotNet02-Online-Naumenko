import React from 'react';
import bgimage from '../../Posts/avatar.jpeg';
import PostAuthorOpinion from '../../Posts/PostAuthorOpinion/PostAuthorOpinion';

const RecommendedSection = (props) => {
    return (
        <section className="section-main pt__3">
            <div className="row g__3">
                <div className="col-xl-6">
                    <PostAuthorOpinion 
                                handleToggle={props.handleToggle} 
                                link={'https://test.test'} 
                                title={'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала'} 
                                date={'Вчера, 21:34'} 
                                views={10} 
                                background={bgimage}
                                height='sm'
                                authorLink='https://author.ru'
                                authorName='Дмитрий Науменко'/>
                </div>
                <div className="col-xl-6">
                    <PostAuthorOpinion 
                                handleToggle={props.handleToggle} 
                                link={'https://test.test'} 
                                title={'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала'} 
                                date={'Вчера, 21:34'} 
                                views={10} 
                                background={bgimage}
                                height='sm'
                                authorLink='https://author.ru'
                                authorName='Дмитрий Науменко'/>
                </div>
                <div className="col-xl-6">
                    <PostAuthorOpinion 
                                handleToggle={props.handleToggle} 
                                link={'https://test.test'} 
                                title={'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала'} 
                                date={'Вчера, 21:34'} 
                                views={10} 
                                background={bgimage}
                                height='sm'
                                authorLink='https://author.ru'
                                authorName='Дмитрий Науменко'/>
                </div>
                <div className="col-xl-6">
                    <PostAuthorOpinion 
                                handleToggle={props.handleToggle} 
                                link={'https://test.test'} 
                                title={'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала'} 
                                date={'Вчера, 21:34'} 
                                views={10} 
                                background={bgimage}
                                height='sm'
                                authorLink='https://author.ru'
                                authorName='Дмитрий Науменко'/>
                </div>
            </div>
        </section>
    );
};

export default RecommendedSection;