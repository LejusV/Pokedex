using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Xatu Species to store common natural stats of all Xatus
	#region SpeciesXatu
	public class SpeciesXatu : PokemonSpecies
	{
#nullable enable
		private static SpeciesXatu? _instance = null;
#nullable restore
        public static SpeciesXatu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesXatu();
                }
                return _instance;
            }
        }

		#region SpeciesXatu Constructor
		public SpeciesXatu() : base(
			"Xatu",
			1.5,
			15.0,
			65, // HPs
			75, 70, // Attack & Defense
			95, 70, // Special Attack & Defense
			95		
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
				"Fly",
				"Double-Edge",
				"Leer",
				"Hyper-Beam",
				"Peck",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Teleport",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
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
				"Secret-Power",
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
				"Air-Slash",
				"Giga-Impact",
				"Zen-Headbutt",
				"Defog",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Ominous-Wind",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
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

	//Xatu PokemonInstance Class
	#region Xatu
	public class XatuInstance : PokemonInstance
	{
		#region Xatu Constructors
		/// <summary>
		/// Xatu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public XatuInstance(string nickname, int level)
		: base(
				178,
				SpeciesXatu.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xatu Builder only waiting for a Level
		/// </summary>
		public XatuInstance(int level)
		: base(
				178,
				SpeciesXatu.Instance, // PokemonInstance Species
				"Xatu", level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xatu Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Xatu() : base(
			178,
			SpeciesXatu.Instance, // PokemonInstance Species
			Psychic.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}