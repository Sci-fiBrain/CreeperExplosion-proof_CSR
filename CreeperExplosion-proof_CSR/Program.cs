/* 
* 创建: ScifiBrain
* 项目: CreeperExplosion-proof_CSR
* 日期: 2020-12-3
* 时间: 13:11
* 介绍: 事件处理方法类
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSR;

namespace CreeperExplosion_proof.csr
{
    public class Creeper
    {
        private MCCSAPI api; //API接口

        #region ---构造函数---
        /// <summary>
        /// 新建一个Creeper实例
        /// </summary>
        public Creeper(MCCSAPI api) { this.api = api; }
        #endregion

        #region ---爆炸事件---
        /// <summary>
        /// 爆炸事件
        /// </summary>
        /// <param name="e">事件参数</param>
        /// <returns>是否继续运行</returns>
        public bool Explode(Events e)
        {
            //获取事件参数
            LevelExplodeEvent explode = BaseEvent.getFrom(e) as LevelExplodeEvent;
            if (explode.entityid == 2849) return false;//拦截2849
            else return true;
        }
        #endregion
    }
}
