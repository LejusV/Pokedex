using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Minior-Red-Meteor Specie to store common natural stats of all Minior-Red-Meteors
	#region SpecieMinior-Red-Meteor
	public class SpecieMiniorRedMeteor : PokemonSpecie
	{
#nullable enable
		private static SpecieMiniorRedMeteor? _instance = null;
#nullable restore
        public static SpecieMiniorRedMeteor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMiniorRedMeteor();
                }
                return _instance;
            }
        }

		#region SpecieMinior-Red-Meteor Builder
		public SpecieMiniorRedMeteor() : base(
			"Minior-Red-Meteor",
			60, // HPs
			60, 100, // Attack & Defense
			60, 100, // Special Attack & Defense
			60		
		)
		{
			this._height = 3;
			this._weight = 400;
		}
		#endregion
	}
	#endregion

	//Minior-Red-Meteor Pokemon Class
	#region Minior-Red-Meteor
	public class MiniorRedMeteor : Pokemon
	{
		#region Minior-Red-Meteor Builders
		/// <summary>
		/// Minior-Red-Meteor Builder waiting for a Nickname & a Level
		/// </summary>
		public MiniorRedMeteor(string nickname, int level)
		: base(
				774,
				SpecieMiniorRedMeteor.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minior-Red-Meteor Builder only waiting for a Level
		/// </summary>
		public MiniorRedMeteor(int level)
		: base(
				774,
				SpecieMiniorRedMeteor.Instance, // Pokemon Specie
				"Minior-Red-Meteor", level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minior-Red-Meteor Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public MiniorRedMeteor() : base(
			774,
			SpecieMiniorRedMeteor.Instance, // Pokemon Specie
			Rock.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}