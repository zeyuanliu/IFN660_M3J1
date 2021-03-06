﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLexTutorial.AST
{
    public interface ILexicalScope
    {
        IDeclaration Resolve(string name);
        void SetParentScope(ILexicalScope parentLexicalScope);
        ILexicalScope GetLexicalScope();

    }
}
