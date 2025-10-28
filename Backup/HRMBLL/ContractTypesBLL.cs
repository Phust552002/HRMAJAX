using System;
using System.Collections.Generic;
using System.Text;

using HRMDAL.HRMTableAdapters;
using HRMDAL;

namespace HRMBLL
{
    [System.ComponentModel.DataObject]
    public class ContractTypesBLL
    {
        private ContractTypesTableAdapter _contractTypesTableAdapter = null;
        protected ContractTypesTableAdapter Adapter
        {
            get
            {
                if (_contractTypesTableAdapter == null)
                    _contractTypesTableAdapter = new ContractTypesTableAdapter();

                return _contractTypesTableAdapter;
            }
        }

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public HRM.ContractTypesDataTable GetAllContractType()
        {
            return Adapter.GetAllContractType();
        }
    }
}
