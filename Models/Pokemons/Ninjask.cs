using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ninjask Specie to store common natural stats of all Ninjasks
	#region SpecieNinjask
	public class SpecieNinjask : PokemonSpecie
	{
#nullable enable
		private static SpecieNinjask? _instance = null;
#nullable restore
        public static SpecieNinjask Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNinjask();
                }
                return _instance;
            }
        }

		#region SpecieNinjask Builder
		public SpecieNinjask() : base(
			"Ninjask",
			61, // HPs
			90, 45, // Attack & Defense
			50, 50, // Special Attack & Defense
			160		
		)
		{
			this._height = 8;
			this._weight = 120;
		}
		#endregion
	}
	#endregion

	//Ninjask Pokemon Class
	#region Ninjask
	public class Ninjask : Pokemon
	{
		#region Ninjask Builders
		/// <summary>
		/// Ninjask Builder waiting for a Nickname & a Level
		/// </summary>
		public Ninjask(string nickname, int level)
		: base(
				291,
				SpecieNinjask.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ninjask Builder only waiting for a Level
		/// </summary>
		public Ninjask(int level)
		: base(
				291,
				SpecieNinjask.Instance, // Pokemon Specie
				"Ninjask", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ninjask Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Ninjask() : base(
			291,
			SpecieNinjask.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}