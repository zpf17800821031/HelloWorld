//
// Copyright (c) ZeroC, Inc. All rights reserved.
//
//
// Ice version 3.7.10
//
// <auto-generated>
//
// Generated from file `Printer.ice'
//
// Warning: do not edit this file.
//
// </auto-generated>
//


using _System = global::System;

#pragma warning disable 1591

namespace Demo
{
    [global::System.Runtime.InteropServices.ComVisible(false)]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1715")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1722")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724")]
    public partial interface Printer : global::Ice.Object, PrinterOperations_
    {
    }
}

namespace Demo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.10")]
    public delegate void Callback_Printer_printString();
}

namespace Demo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.10")]
    public interface PrinterPrx : global::Ice.ObjectPrx
    {
        void printString(string s, global::Ice.OptionalContext context = new global::Ice.OptionalContext());

        global::System.Threading.Tasks.Task printStringAsync(string s, global::Ice.OptionalContext context = new global::Ice.OptionalContext(), global::System.IProgress<bool> progress = null, global::System.Threading.CancellationToken cancel = new global::System.Threading.CancellationToken());

        global::Ice.AsyncResult<Callback_Printer_printString> begin_printString(string s, global::Ice.OptionalContext context = new global::Ice.OptionalContext());

        global::Ice.AsyncResult begin_printString(string s, global::Ice.AsyncCallback callback, object cookie);

        global::Ice.AsyncResult begin_printString(string s, global::Ice.OptionalContext context, global::Ice.AsyncCallback callback, object cookie);

        void end_printString(global::Ice.AsyncResult asyncResult);
    }
}

namespace Demo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.10")]
    public interface PrinterOperations_
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.10")]
        void printString(string s, global::Ice.Current current = null);
    }
}

namespace Demo
{
    [global::System.Runtime.InteropServices.ComVisible(false)]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.10")]
    [global::System.Serializable]
    public sealed class PrinterPrxHelper : global::Ice.ObjectPrxHelperBase, PrinterPrx
    {
        public PrinterPrxHelper()
        {
        }

        public PrinterPrxHelper(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        #region Synchronous operations

        public void printString(string s, global::Ice.OptionalContext context = new global::Ice.OptionalContext())
        {
            try
            {
                _iceI_printStringAsync(s, context, null, global::System.Threading.CancellationToken.None, true).Wait();
            }
            catch(global::System.AggregateException ex_)
            {
                throw ex_.InnerException;
            }
        }

        #endregion

        #region Async Task operations

        public global::System.Threading.Tasks.Task printStringAsync(string s, global::Ice.OptionalContext context = new global::Ice.OptionalContext(), global::System.IProgress<bool> progress = null, global::System.Threading.CancellationToken cancel = new global::System.Threading.CancellationToken())
        {
            return _iceI_printStringAsync(s, context, progress, cancel, false);
        }

        private global::System.Threading.Tasks.Task _iceI_printStringAsync(string iceP_s, global::Ice.OptionalContext context, global::System.IProgress<bool> progress, global::System.Threading.CancellationToken cancel, bool synchronous)
        {
            var completed = new global::IceInternal.OperationTaskCompletionCallback<object>(progress, cancel);
            _iceI_printString(iceP_s, context, synchronous, completed);
            return completed.Task;
        }

        private const string _printString_name = "printString";

        private void _iceI_printString(string iceP_s, global::System.Collections.Generic.Dictionary<string, string> context, bool synchronous, global::IceInternal.OutgoingAsyncCompletionCallback completed)
        {
            var outAsync = getOutgoingAsync<object>(completed);
            outAsync.invoke(
                _printString_name,
                global::Ice.OperationMode.Normal,
                global::Ice.FormatType.DefaultFormat,
                context,
                synchronous,
                write: (global::Ice.OutputStream ostr) =>
                {
                    ostr.writeString(iceP_s);
                });
        }

        #endregion

        #region Asynchronous operations

        public global::Ice.AsyncResult<Callback_Printer_printString> begin_printString(string s, global::Ice.OptionalContext context = new global::Ice.OptionalContext())
        {
            return begin_printString(s, context, null, null, false);
        }

        public global::Ice.AsyncResult begin_printString(string s, global::Ice.AsyncCallback callback, object cookie)
        {
            return begin_printString(s, new global::Ice.OptionalContext(), callback, cookie, false);
        }

        public global::Ice.AsyncResult begin_printString(string s, global::Ice.OptionalContext context, global::Ice.AsyncCallback callback, object cookie)
        {
            return begin_printString(s, context, callback, cookie, false);
        }

        public void end_printString(global::Ice.AsyncResult asyncResult)
        {
            var resultI_ = global::IceInternal.AsyncResultI.check(asyncResult, this, _printString_name);
            ((global::IceInternal.OutgoingAsyncT<object>)resultI_.OutgoingAsync).getResult(resultI_.wait());
        }

        private global::Ice.AsyncResult<Callback_Printer_printString> begin_printString(string iceP_s, global::System.Collections.Generic.Dictionary<string, string> context, global::Ice.AsyncCallback completedCallback, object cookie, bool synchronous)
        {
            var completed = new global::IceInternal.OperationAsyncResultCompletionCallback<Callback_Printer_printString, object>(
                (Callback_Printer_printString cb, object ret) =>
                {
                    if(cb != null)
                    {
                        cb.Invoke();
                    }
                },
                this, _printString_name, cookie, completedCallback);
            _iceI_printString(iceP_s, context, synchronous, completed);
            return completed;
        }

        #endregion

        #region Checked and unchecked cast operations

        public static PrinterPrx checkedCast(global::Ice.ObjectPrx b)
        {
            if(b == null)
            {
                return null;
            }
            PrinterPrx r = b as PrinterPrx;
            if((r == null) && b.ice_isA(ice_staticId()))
            {
                PrinterPrxHelper h = new PrinterPrxHelper();
                h.iceCopyFrom(b);
                r = h;
            }
            return r;
        }

        public static PrinterPrx checkedCast(global::Ice.ObjectPrx b, global::System.Collections.Generic.Dictionary<string, string> ctx)
        {
            if(b == null)
            {
                return null;
            }
            PrinterPrx r = b as PrinterPrx;
            if((r == null) && b.ice_isA(ice_staticId(), ctx))
            {
                PrinterPrxHelper h = new PrinterPrxHelper();
                h.iceCopyFrom(b);
                r = h;
            }
            return r;
        }

        public static PrinterPrx checkedCast(global::Ice.ObjectPrx b, string f)
        {
            if(b == null)
            {
                return null;
            }
            global::Ice.ObjectPrx bb = b.ice_facet(f);
            try
            {
                if(bb.ice_isA(ice_staticId()))
                {
                    PrinterPrxHelper h = new PrinterPrxHelper();
                    h.iceCopyFrom(bb);
                    return h;
                }
            }
            catch(global::Ice.FacetNotExistException)
            {
            }
            return null;
        }

        public static PrinterPrx checkedCast(global::Ice.ObjectPrx b, string f, global::System.Collections.Generic.Dictionary<string, string> ctx)
        {
            if(b == null)
            {
                return null;
            }
            global::Ice.ObjectPrx bb = b.ice_facet(f);
            try
            {
                if(bb.ice_isA(ice_staticId(), ctx))
                {
                    PrinterPrxHelper h = new PrinterPrxHelper();
                    h.iceCopyFrom(bb);
                    return h;
                }
            }
            catch(global::Ice.FacetNotExistException)
            {
            }
            return null;
        }

        public static PrinterPrx uncheckedCast(global::Ice.ObjectPrx b)
        {
            if(b == null)
            {
                return null;
            }
            PrinterPrx r = b as PrinterPrx;
            if(r == null)
            {
                PrinterPrxHelper h = new PrinterPrxHelper();
                h.iceCopyFrom(b);
                r = h;
            }
            return r;
        }

        public static PrinterPrx uncheckedCast(global::Ice.ObjectPrx b, string f)
        {
            if(b == null)
            {
                return null;
            }
            global::Ice.ObjectPrx bb = b.ice_facet(f);
            PrinterPrxHelper h = new PrinterPrxHelper();
            h.iceCopyFrom(bb);
            return h;
        }

        private static readonly string[] _ids =
        {
            "::Demo::Printer",
            "::Ice::Object"
        };

        public static string ice_staticId()
        {
            return _ids[0];
        }

        #endregion

        #region Marshaling support

        public static void write(global::Ice.OutputStream ostr, PrinterPrx v)
        {
            ostr.writeProxy(v);
        }

        public static PrinterPrx read(global::Ice.InputStream istr)
        {
            global::Ice.ObjectPrx proxy = istr.readProxy();
            if(proxy != null)
            {
                PrinterPrxHelper result = new PrinterPrxHelper();
                result.iceCopyFrom(proxy);
                return result;
            }
            return null;
        }

        #endregion
    }
}

namespace Demo
{
    [global::System.Runtime.InteropServices.ComVisible(false)]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.10")]
    public abstract class PrinterDisp_ : global::Ice.ObjectImpl, Printer
    {
        #region Slice operations

        public abstract void printString(string s, global::Ice.Current current = null);

        #endregion

        #region Slice type-related members

        private static readonly string[] _ids =
        {
            "::Demo::Printer",
            "::Ice::Object"
        };

        public override bool ice_isA(string s, global::Ice.Current current = null)
        {
            return global::System.Array.BinarySearch(_ids, s, IceUtilInternal.StringUtil.OrdinalStringComparer) >= 0;
        }

        public override string[] ice_ids(global::Ice.Current current = null)
        {
            return _ids;
        }

        public override string ice_id(global::Ice.Current current = null)
        {
            return _ids[0];
        }

        public static new string ice_staticId()
        {
            return _ids[0];
        }

        #endregion

        #region Operation dispatch

        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static global::System.Threading.Tasks.Task<global::Ice.OutputStream>
        iceD_printString(Printer obj, global::IceInternal.Incoming inS, global::Ice.Current current)
        {
            global::Ice.ObjectImpl.iceCheckMode(global::Ice.OperationMode.Normal, current.mode);
            var istr = inS.startReadParams();
            string iceP_s;
            iceP_s = istr.readString();
            inS.endReadParams();
            obj.printString(iceP_s, current);
            return inS.setResult(inS.writeEmptyParams());
        }

        private static readonly string[] _all =
        {
            "ice_id",
            "ice_ids",
            "ice_isA",
            "ice_ping",
            "printString"
        };

        public override global::System.Threading.Tasks.Task<global::Ice.OutputStream>
        iceDispatch(global::IceInternal.Incoming inS, global::Ice.Current current)
        {
            int pos = global::System.Array.BinarySearch(_all, current.operation, global::IceUtilInternal.StringUtil.OrdinalStringComparer);
            if(pos < 0)
            {
                throw new global::Ice.OperationNotExistException(current.id, current.facet, current.operation);
            }

            switch(pos)
            {
                case 0:
                {
                    return global::Ice.ObjectImpl.iceD_ice_id(this, inS, current);
                }
                case 1:
                {
                    return global::Ice.ObjectImpl.iceD_ice_ids(this, inS, current);
                }
                case 2:
                {
                    return global::Ice.ObjectImpl.iceD_ice_isA(this, inS, current);
                }
                case 3:
                {
                    return global::Ice.ObjectImpl.iceD_ice_ping(this, inS, current);
                }
                case 4:
                {
                    return iceD_printString(this, inS, current);
                }
            }

            global::System.Diagnostics.Debug.Assert(false);
            throw new global::Ice.OperationNotExistException(current.id, current.facet, current.operation);
        }

        #endregion
    }
}
