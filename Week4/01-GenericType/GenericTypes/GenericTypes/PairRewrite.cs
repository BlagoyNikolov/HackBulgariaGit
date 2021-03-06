﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes {
        class PairRewrite<B, N> {
            private B object1 { get; set; }
            private N object2 { get; set; }

            public PairRewrite(B object1, N object2) {
                this.object1 = object1;
                this.object2 = object2;
            }

            public static bool operator ==(PairRewrite<B, N> pair1, PairRewrite<B, N> pair2) {
                if (pair1.Equals(pair2))
                    return true;
                else
                    return false;
            }

            public static bool operator !=(PairRewrite<B, N> pair1, PairRewrite<B, N> pair2) {
                if (!pair1.Equals(pair2))
                    return true;
                else
                    return false;
            }

            public override int GetHashCode() {
                unchecked {
                    int hash = 17;
                    hash = hash * 23 + object1.GetHashCode();
                    hash = hash * 23 + object2.GetHashCode();
                    return hash;
                }
            }

            public override bool Equals(System.Object obj) {
                if (obj is PairRewrite<B, N>) {
                PairRewrite<B, N> obj1 = this;
                PairRewrite<B, N> obj2 = (PairRewrite<B, N>)obj;

                    if (obj1.object1.Equals(obj2.object1) && obj1.object2.Equals(obj2.object2)) {
                        return true;
                    }
                    else {
                        return false;
                    }
                }
                else { return false; }
            }

            public override string ToString() {
                return String.Format("{0} | {1}", object1, object2);
            }
        }
    }
