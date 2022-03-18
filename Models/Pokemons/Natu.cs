using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Natu Species to store common natural stats of all Natus
	#region SpeciesNatu
	public class SpeciesNatu : PokemonSpecies
	{
#nullable enable
		private static SpeciesNatu? _instance = null;
#nullable restore
        public static SpeciesNatu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNatu();
                }
                return _instance;
            }
        }

		#region SpeciesNatu Constructor
		public SpeciesNatu() : base(
			177,
			"Natu",
			0.2,
			2.0,
			40, // HPs
			50, 45, // Attack & Defense
			70, 45, // Special Attack & Defense
			70		
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
				"Double-Edge",
				"Leer",
				"Peck",
				"Drill-Peck",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Quick-Attack",
				"Teleport",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Haze",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Feint-Attack",
				"Detect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Heat-Wave",
				"Facade",
				"Trick",
				"Wish",
				"Magic-Coat",
				"Skill-Swap",
				"Refresh",
				"Secret-Power",
				"Feather-Dance",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"Miracle-Eye",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Psycho-Shift",
				"Lucky-Chant",
				"Me-First",
				"Power-Swap",
				"Guard-Swap",
				"Sucker-Punch",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Ominous-Wind",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Synchronoise",
				"Simple-Beam",
				"Round",
				"Stored-Power",
				"Ally-Switch",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Natu PokemonInstance Class
	#region Natu
	public class NatuInstance : PokemonInstance
	{
		#region Natu Constructors
		/// <summary>
		/// Natu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NatuInstance(string nickname, int level)
		: base(
				SpeciesNatu.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Natu Builder only waiting for a Level
		/// </summary>
		public NatuInstance(int level)
		: base(
				SpeciesNatu.Instance, // PokemonInstance Species
				"Natu", level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Natu Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public NatuInstance() : base(
			SpeciesNatu.Instance, // PokemonInstance Species
			Psychic.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}