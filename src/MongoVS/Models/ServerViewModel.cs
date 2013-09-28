﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using MongoDB.VisualStudio.Presenters;

namespace MongoDB.VisualStudio.Models
{
    public class ServerViewModel : TreeItemViewModelWithChildren
    {
        private readonly ServerPresenter _presenter;

        public ServerViewModel(ServerPresenter presenter)
        {
            _presenter = presenter;
        }

        public override string Name
        {
            get { return _presenter.Address; }
        }

        protected override IEnumerable<ITreeItemViewModel> LoadChildren()
        {
            return _presenter.GetChildren();
        }
    }
}