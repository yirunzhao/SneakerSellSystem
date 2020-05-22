using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SneakerSellSystem.Class;

namespace SneakerSellSystem
{
    // 定义一些错误的返回值
    enum BuyErrorType { InsufficientFunds,InsufficientProducts,NoneError};

    public class Member
    {
        //定义会员的一些属性
        public int MID { get; set; }
        public string Name  { get; set; }   //会员名字
        public string PhoneNumber { get; set; } //会员电话号码
        public string Address { get; set; } //会员收货地址
        public string Password { get; set; }
        public string Email { get; set; }
        public int Level { get; set; }
        public int Balance { get; set; }
        public int Point { get; set; }
        public int CID { get; set; }

        // 优化后的buy
        public int Buy(SqlParameter[] pms, int price, int index, List<Shoe> shoeList)
        {
            string sql = "insert Buyinfo values(@uid,@cid,@exp,@sname,@status)";

            // 如果是普通用户
            if(this.Level < 4)
            {
                // 如果不够买
                if(this.Balance < price*Utils.discount[this.Level - 1])
                {
                    return (int)BuyErrorType.InsufficientFunds;
                }
                // 商品不够
                else if (shoeList[index].Count == 0)
                {
                    return (int)BuyErrorType.InsufficientProducts;
                }
                // 进行购买
                else
                {
                    int r = SqlHelper.ExecuteNonQuery(sql, pms);
                    if(r > 0)
                    {
                        // 减少余额
                        this.Balance -= (int)(price * Utils.discount[this.Level - 1]);
                        // 增加积分
                        this.Point += (int)(price * Utils.cvtPoints[this.Level - 1]);
                        // 改变用户等级
                        // level 1 : 0 - 1999
                        // level 2 : 2000 - 4999
                        // level 3 : 5000 ---
                        if (this.Point < 2000)
                        {
                            this.Level = 1;
                        }
                        else if (this.Point < 5000)
                        {
                            this.Level = 2;
                        }
                        else
                        {
                            this.Level = 3;
                        }
                    }
                    
                }
                return (int)BuyErrorType.NoneError;
            }
            // 如果是管理员
            else
            {
                int r = SqlHelper.ExecuteNonQuery(sql, pms);
                // 因为不用钱，所以判断能不能买
                if(shoeList[index].Count == 0)
                {
                    return (int)BuyErrorType.InsufficientProducts;
                }
                return (int)BuyErrorType.NoneError;
            }
        }

        #region 未优化版本
        //public int Buy(SqlParameter[] pms, int price,int index,List<Shoe> shoeList)
        //{
        //    string sql = "insert Buyinfo values(@uid,@cid,@exp,@sname,@status)";

        //    switch (this.Level)
        //    {
        //        //会员等级1
        //        case 1:
        //            if (this.Balance < price)
        //            {
        //                return (int)BuyErrorType.InsufficientFunds;
        //            }
        //            else if (shoeList[index].Count == 0)
        //            {
        //                return (int)BuyErrorType.InsufficientProducts;
        //            }
        //            else
        //            {
        //                //在这里执行购买
        //                int r1 = SqlHelper.ExecuteNonQuery(sql, pms);
        //                if (r1 > 0)
        //                {
        //                    this.Balance -= price;
        //                    this.Point += (int)(price * 0.1);
        //                    switch (this.Point / 1000)
        //                    {
        //                        case 0:
        //                        case 1:
        //                        case 2:
        //                        case 3:
        //                        case 4:
        //                            if (this.Level < 2 && this.Point >= 1000)
        //                            {
        //                                this.Level = 2;
        //                            }
        //                            break;
        //                        default:
        //                            if (this.Level < 3 && this.Point >= 5000)
        //                            {
        //                                this.Level = 3;
        //                            }
        //                            break;
        //                    }
        //                    //然后更新数据库的信息

        //                }
        //            }
        //            break;
        //        //会员等级2
        //        case 2:
        //            if (this.Balance < (int)(price * 0.8))
        //            {
        //                return (int)BuyErrorType.InsufficientFunds;
        //            }
        //            else if (shoeList[index].Count == 0)
        //            {
        //                return (int)BuyErrorType.InsufficientProducts;
        //            }
        //            else
        //            {
        //                //在这里执行购买
        //                int r2 = SqlHelper.ExecuteNonQuery(sql, pms);
        //                if (r2 > 0)
        //                {
        //                    this.Balance -= (int)(price * 0.8);
        //                    this.Point += (int)(price * 0.2);
        //                    switch (this.Point / 1000)
        //                    {
        //                        case 0:
        //                        case 1:
        //                        case 2:
        //                        case 3:
        //                        case 4:
        //                            if (this.Level < 2 && this.Point >= 1000)
        //                            {
        //                                this.Level = 2;
        //                            }
        //                            break;
        //                        default:
        //                            if (this.Level < 3 && this.Point >= 5000)
        //                            {
        //                                this.Level = 3;
        //                            }
        //                            break;
        //                    }
        //                    //然后更新数据库的信息
        //                }

        //            }
        //            break;
        //        //会员等级3
        //        case 3:
        //            if (this.Balance < (int)(price * 0.7))
        //            {
        //                return (int)BuyErrorType.InsufficientFunds;
        //            }
        //            else if (shoeList[index].Count == 0)
        //            {
        //                return (int)BuyErrorType.InsufficientProducts;
        //            }
        //            else
        //            {
        //                //在这里执行购买
        //                int r3 = SqlHelper.ExecuteNonQuery(sql, pms);
        //                if (r3 > 0)
        //                {
        //                    this.Balance -= (int)(price * 0.7);
        //                    this.Point += (int)(price * 0.3);
        //                    switch (this.Point / 1000)
        //                    {
        //                        case 0:
        //                        case 1:
        //                        case 2:
        //                        case 3:
        //                        case 4:
        //                            if (this.Level < 2 && this.Point >= 1000)
        //                            {
        //                                this.Level = 2;
        //                            }
        //                            break;
        //                        default:
        //                            if (this.Level < 3 && this.Point >= 5000)
        //                            {
        //                                this.Level = 3;
        //                            }
        //                            break;
        //                    }
        //                    //然后更新数据库的信息
        //                }

        //            }
        //            break;
        //        //管理员，随便买
        //        case 4:
        //            //在这里执行购买
        //            int r4 = SqlHelper.ExecuteNonQuery(sql, pms);
        //            if (shoeList[index].Count == 0)
        //            {
        //                return (int)BuyErrorType.InsufficientProducts;
        //            }
        //            //if (r4 > 0)
        //            //{
        //            //    return (int)BuyErrorType.NoneError;
        //            //}
        //            break;
        //        default: break;
        //    }
        //    return (int)BuyErrorType.NoneError;
        //}
        #endregion
    }
}
