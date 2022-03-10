using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Azelf Species to store common natural stats of all Azelfs
	#region SpeciesAzelf
	public class SpeciesAzelf : PokemonSpecies
	{
#nullable enable
		private static SpeciesAzelf? _instance = null;
#nullable restore
        public static SpeciesAzelf Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAzelf();
                }
                return _instance;
            }
        }

		#region SpeciesAzelf Constructor
		public SpeciesAzelf() : base(
			"Azelf",
			0.3,
			0.3,
			75, // HPs
			125, 70, // Attack & Defense
			125, 70, // Special Attack & Defense
			115		
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Flamethrower",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Fire-Blast",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Explosion",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Knock-Off",
				"Skill-Swap",
				"Imprison",
				"Secret-Power",
				"Signal-Beam",
				"Extrasensory",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"U-Turn",
				"Payback",
				"Fling",
				"Last-Resort",
				"Energy-Ball",
				"Giga-Impact",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Trick-Room",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Round",
				"Incinerate",
				"Acrobatics",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Azelf PokemonInstance Class
	#region Azelf
	public class AzelfInstance : PokemonInstance
	{
		#region Azelf Constructors
		/// <summary>
		/// Azelf Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AzelfInstance(string nickname, int level)
		: base(
				482,
				SpeciesAzelf.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azelf Builder only waiting for a Level
		/// </summary>
		public AzelfInstance(int level)
		: base(
				482,
				SpeciesAzelf.Instance, // PokemonInstance Species
				"Azelf", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azelf Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Azelf() : base(
			482,
			SpeciesAzelf.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}