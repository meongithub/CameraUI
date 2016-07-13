/* LCM type definition class file
 * This file was automatically generated by lcm-gen
 * DO NOT MODIFY BY HAND!!!!
 */

using System;
using System.Collections.Generic;
using System.IO;
using LCM.LCM;
 
namespace ptz_camera
{
    public sealed class position_response_t : LCM.LCM.LCMEncodable
    {
        public String ip_address;
        public String pan_value;
        public String tilt_value;
        public String zoom_value;
        public short status_code;
        public String response_message;
 
        public position_response_t()
        {
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0x3a976f7098d0a636L;
 
        static position_response_t()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("ptz_camera.position_response_t"))
                return 0L;
 
            classes.Add("ptz_camera.position_response_t");
            ulong hash = LCM_FINGERPRINT_BASE
                ;
            classes.RemoveAt(classes.Count - 1);
            return (hash<<1) + ((hash>>63)&1);
        }
 
        public void Encode(LCMDataOutputStream outs)
        {
            outs.Write((long) LCM_FINGERPRINT);
            _encodeRecursive(outs);
        }
 
        public void _encodeRecursive(LCMDataOutputStream outs)
        {
            byte[] __strbuf = null;
            __strbuf = System.Text.Encoding.GetEncoding("US-ASCII").GetBytes(this.ip_address); outs.Write(__strbuf.Length+1); outs.Write(__strbuf, 0, __strbuf.Length); outs.Write((byte) 0); 
 
            __strbuf = System.Text.Encoding.GetEncoding("US-ASCII").GetBytes(this.pan_value); outs.Write(__strbuf.Length+1); outs.Write(__strbuf, 0, __strbuf.Length); outs.Write((byte) 0); 
 
            __strbuf = System.Text.Encoding.GetEncoding("US-ASCII").GetBytes(this.tilt_value); outs.Write(__strbuf.Length+1); outs.Write(__strbuf, 0, __strbuf.Length); outs.Write((byte) 0); 
 
            __strbuf = System.Text.Encoding.GetEncoding("US-ASCII").GetBytes(this.zoom_value); outs.Write(__strbuf.Length+1); outs.Write(__strbuf, 0, __strbuf.Length); outs.Write((byte) 0); 
 
            outs.Write(this.status_code); 
 
            __strbuf = System.Text.Encoding.GetEncoding("US-ASCII").GetBytes(this.response_message); outs.Write(__strbuf.Length+1); outs.Write(__strbuf, 0, __strbuf.Length); outs.Write((byte) 0); 
 
        }
 
        public position_response_t(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public position_response_t(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static ptz_camera.position_response_t _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            ptz_camera.position_response_t o = new ptz_camera.position_response_t();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            byte[] __strbuf = null;
            __strbuf = new byte[ins.ReadInt32()-1]; ins.ReadFully(__strbuf); ins.ReadByte(); this.ip_address = System.Text.Encoding.GetEncoding("US-ASCII").GetString(__strbuf);
 
            __strbuf = new byte[ins.ReadInt32()-1]; ins.ReadFully(__strbuf); ins.ReadByte(); this.pan_value = System.Text.Encoding.GetEncoding("US-ASCII").GetString(__strbuf);
 
            __strbuf = new byte[ins.ReadInt32()-1]; ins.ReadFully(__strbuf); ins.ReadByte(); this.tilt_value = System.Text.Encoding.GetEncoding("US-ASCII").GetString(__strbuf);
 
            __strbuf = new byte[ins.ReadInt32()-1]; ins.ReadFully(__strbuf); ins.ReadByte(); this.zoom_value = System.Text.Encoding.GetEncoding("US-ASCII").GetString(__strbuf);
 
            this.status_code = ins.ReadInt16();
 
            __strbuf = new byte[ins.ReadInt32()-1]; ins.ReadFully(__strbuf); ins.ReadByte(); this.response_message = System.Text.Encoding.GetEncoding("US-ASCII").GetString(__strbuf);
 
        }
 
        public ptz_camera.position_response_t Copy()
        {
            ptz_camera.position_response_t outobj = new ptz_camera.position_response_t();
            outobj.ip_address = this.ip_address;
 
            outobj.pan_value = this.pan_value;
 
            outobj.tilt_value = this.tilt_value;
 
            outobj.zoom_value = this.zoom_value;
 
            outobj.status_code = this.status_code;
 
            outobj.response_message = this.response_message;
 
            return outobj;
        }
    }
}

