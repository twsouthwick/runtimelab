using System.Collections;
using System.Collections.Specialized;

namespace System.Web.SessionState
{
    public sealed partial class HttpSessionState : ICollection
    {
        private readonly IHttpSessionState _container;

        public HttpSessionState(IHttpSessionState container)
        {
            _container = container;
        }

        /*
         * The Id of the session.
         */

        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public String SessionID
        {
            get { return _container.SessionID; }
        }

        /*
         * The length of a session before it times out, in minutes.
         */

        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public int Timeout
        {
            get { return _container.Timeout; }
            set { _container.Timeout = value; }
        }

        /*
         * Is this a new session?
         */

        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public bool IsNewSession
        {
            get { return _container.IsNewSession; }
        }

        /*
         * Is session state in a separate process
         */

        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public SessionStateMode Mode
        {
            get { return _container.Mode; }
        }

        /*
         * Is session state cookieless?
         */
        public bool IsCookieless
        {
            get { return _container.IsCookieless; }
        }

        public HttpCookieMode CookieMode
        {
            get { return _container.CookieMode; }
        }

        /*
         * Abandon the session.
         *
         */

        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public void Abandon()
        {
            _container.Abandon();
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public int LCID
        {
            get { return _container.LCID; }
            set { _container.LCID = value; }
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public int CodePage
        {
            get { return _container.CodePage; }
            set { _container.CodePage = value; }
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public HttpSessionState Contents
        {
            get { return this; }
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public HttpStaticObjectsCollection StaticObjects
        {
            get { return _container.StaticObjects; }
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public Object this[String name]
        {
            get
            {
                return _container[name];
            }
            set
            {
                _container[name] = value;
            }
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public Object this[int index]
        {
            get { return _container[index]; }
            set { _container[index] = value; }
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public void Add(String name, Object value)
        {
            _container[name] = value;
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public void Remove(String name)
        {
            _container.Remove(name);
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public void RemoveAt(int index)
        {
            _container.RemoveAt(index);
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public void Clear()
        {
            _container.Clear();
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public void RemoveAll()
        {
            Clear();
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public int Count
        {
            get { return _container.Count; }
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public NameObjectCollectionBase.KeysCollection Keys
        {
            get { return _container.Keys; }
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public IEnumerator GetEnumerator()
        {
            return _container.GetEnumerator();
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public void CopyTo(Array array, int index)
        {
            _container.CopyTo(array, index);
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public Object SyncRoot
        {
            get { return _container.SyncRoot; }
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public bool IsReadOnly
        {
            get { return _container.IsReadOnly; }
        }


        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public bool IsSynchronized
        {
            get { return _container.IsSynchronized; }
        }
    }
}
