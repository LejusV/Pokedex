using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Furret Specie to store common natural stats of all Furrets
	#region SpecieFurret
	public class SpecieFurret : PokemonSpecie
	{
#nullable enable
		private static SpecieFurret? _instance = null;
#nullable restore
        public static SpecieFurret Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFurret();
                }
                return _instance;
            }
        }

		#region SpecieFurret Builder
		public SpecieFurret() : base(
			"Furret",
			85, // HPs
			76, 64, // Attack & Defense
			45, 55, // Special Attack & Defense
			90		
		)
		{
			this._height = 18;
			this._weight = 325;
		}
		#endregion
	}
	#endregion

	//Furret Pokemon Class
	#region Furret
	public class Furret : Pokemon
	{
		#region Furret Builders
		/// <summary>
		/// Furret Builder waiting for a Nickname & a Level
		/// </summary>
		public Furret(string nickname, int level)
		: base(
				162,
				SpecieFurret.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Furret Builder only waiting for a Level
		/// </summary>
		public Furret(int level)
		: base(
				162,
				SpecieFurret.Instance, // Pokemon Specie
				"Furret", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Furret Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Furret() : base(
			162,
			SpecieFurret.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}