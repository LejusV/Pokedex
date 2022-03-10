using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cresselia Species to store common natural stats of all Cresselias
	#region SpeciesCresselia
	public class SpeciesCresselia : PokemonSpecies
	{
#nullable enable
		private static SpeciesCresselia? _instance = null;
#nullable restore
        public static SpeciesCresselia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCresselia();
                }
                return _instance;
            }
        }

		#region SpeciesCresselia Constructor
		public SpeciesCresselia() : base(
			"Cresselia",
			1.5,
			85.6,
			120, // HPs
			70, 120, // Attack & Defense
			75, 130, // Special Attack & Defense
			85		
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
				"Mist",
				"Ice-Beam",
				"Aurora-Beam",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Moonlight",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Secret-Power",
				"Signal-Beam",
				"Calm-Mind",
				"Gravity",
				"Natural-Gift",
				"Psycho-Shift",
				"Energy-Ball",
				"Giga-Impact",
				"Psycho-Cut",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Lunar-Dance",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Round",
				"Moonblast",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Cresselia PokemonInstance Class
	#region Cresselia
	public class CresseliaInstance : PokemonInstance
	{
		#region Cresselia Constructors
		/// <summary>
		/// Cresselia Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CresseliaInstance(string nickname, int level)
		: base(
				488,
				SpeciesCresselia.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cresselia Builder only waiting for a Level
		/// </summary>
		public CresseliaInstance(int level)
		: base(
				488,
				SpeciesCresselia.Instance, // PokemonInstance Species
				"Cresselia", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cresselia Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Cresselia() : base(
			488,
			SpeciesCresselia.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}