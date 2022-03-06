using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Electrode Specie to store common natural stats of all Electrodes
	#region SpecieElectrode
	public class SpecieElectrode : PokemonSpecie
	{
#nullable enable
		private static SpecieElectrode? _instance = null;
#nullable restore
        public static SpecieElectrode Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieElectrode();
                }
                return _instance;
            }
        }

		#region SpecieElectrode Builder
		public SpecieElectrode() : base(
			"Electrode",
			1.2,
			66.6,
			60, // HPs
			50, 70, // Attack & Defense
			80, 80, // Special Attack & Defense
			150		
		)
		{}
		#endregion
	}
	#endregion

	//Electrode Pokemon Class
	#region Electrode
	public class Electrode : Pokemon
	{
		#region Electrode Builders
		/// <summary>
		/// Electrode Builder waiting for a Nickname & a Level
		/// </summary>
		public Electrode(string nickname, int level)
		: base(
				101,
				SpecieElectrode.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electrode Builder only waiting for a Level
		/// </summary>
		public Electrode(int level)
		: base(
				101,
				SpecieElectrode.Instance, // Pokemon Specie
				"Electrode", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electrode Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Electrode() : base(
			101,
			SpecieElectrode.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}