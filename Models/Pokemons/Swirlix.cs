using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Swirlix Species to store common natural stats of all Swirlixs
	#region SpeciesSwirlix
	public class SpeciesSwirlix : PokemonSpecies
	{
#nullable enable
		private static SpeciesSwirlix? _instance = null;
#nullable restore
        public static SpeciesSwirlix Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSwirlix();
                }
                return _instance;
            }
        }

		#region SpeciesSwirlix Constructor
		public SpeciesSwirlix() : base(
			684,
			"Swirlix",
			0.4,
			3.5,
			62, // HPs
			48, 66, // Attack & Defense
			59, 57, // Special Attack & Defense
			49		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Tackle",
				"Flamethrower",
				"Surf",
				"Thunderbolt",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Cotton-Spore",
				"Protect",
				"Belly-Drum",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Facade",
				"Helping-Hand",
				"Wish",
				"Magic-Coat",
				"Yawn",
				"Endeavor",
				"Secret-Power",
				"Aromatherapy",
				"Fake-Tears",
				"Covet",
				"Calm-Mind",
				"Gastro-Acid",
				"Copycat",
				"Energy-Ball",
				"After-You",
				"Round",
				"Cotton-Guard",
				"Sticky-Web",
				"Draining-Kiss",
				"Play-Rough",
				"Fairy-Wind",
				"Play-Nice",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Swirlix PokemonInstance Class
	#region Swirlix
	public class SwirlixInstance : PokemonInstance
	{
		#region Swirlix Constructors
		/// <summary>
		/// Swirlix Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SwirlixInstance(string nickname, int level)
		: base(
				SpeciesSwirlix.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swirlix Builder only waiting for a Level
		/// </summary>
		public SwirlixInstance(int level)
		: base(
				SpeciesSwirlix.Instance, // PokemonInstance Species
				"Swirlix", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swirlix Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SwirlixInstance() : base(
			SpeciesSwirlix.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}