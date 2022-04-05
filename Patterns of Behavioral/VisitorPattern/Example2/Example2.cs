using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Example2
{
    abstract class Dokuman
    {
        public string Text { get; set; }

        public Dokuman(string text)
        {
            Text = text;
        }
        public abstract void Accept(IFormat format);
    }

    class Bold : Dokuman
    {
        public Bold(string text) : base(text)
        {

        }
        public override void Accept(IFormat format)
        {
            format.Visit(this);
        }
    }
    class HyperLınk : Dokuman
    {
        public HyperLınk(string text) : base(text)
        {

        }
        public override void Accept(IFormat format)
        {
            format.Visit(this);
        }
    }
    class NormalText : Dokuman
    {
        public NormalText(string text) : base(text)
        {

        }
        public override void Accept(IFormat format)
        {
            format.Visit(this);
        }
    }

    abstract class IFormat
    {
        public string _output;
        public string Output
        {
            get { return _output; }
            set { _output = value; }
        }

        public abstract void Visit(Bold bold);
        public abstract void Visit(HyperLınk hyperLınk);
        public abstract void Visit(NormalText normalText);
    }
    class Html : IFormat
    {

        public override void Visit(Bold bold)
        {
            Output += "<b>" + bold.Text + "</b>";
        }

        public override void Visit(HyperLınk hyperLınk)
        {
            throw new NotImplementedException();
        }

        public override void Visit(NormalText normalText)
        {
            throw new NotImplementedException();
        }
    }
}
