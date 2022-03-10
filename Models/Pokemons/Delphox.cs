using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Delphox Species to store common natural stats of all Delphoxs
	#region SpeciesDelphox
	public class SpeciesDelphox : PokemonSpecies
	{
#nullable enable
		private static SpeciesDelphox? _instance = null;
#nullable restore
        public static SpeciesDelphox Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDelphox();
                }
                return _instance;
            }
        }

		#region SpeciesDelphox Constructor
		public SpeciesDelphox() : base(
			"Delphox",
			1.5,
			39.0,
			75, // HPs
			69, 72, // Attack & Defense
			114, 100, // Special Attack & Defense
			104		
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
				"Thunder-Punch",
				"Scratch",
				"Cut",
				"Tail-Whip",
				"Ember",
				"Flamethrower",
				"Psybeam",
				"Hyper-Beam",
				"Low-Kick",
				"Solar-Beam",
				"Fire-Spin",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Fire-Blast",
				"Dream-Eater",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Swagger",
				"Attract",
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
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Blast-Burn",
				"Overheat",
				"Signal-Beam",
				"Howl",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Embargo",
				"Lucky-Chant",
				"Switcheroo",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Grass-Knot",
				"Wonder-Room",
				"Psyshock",
				"Magic-Room",
				"Flame-Charge",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Fire-Pledge",
				"Work-Up",
				"Confide",
				"Mystical-Fire",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Delphox PokemonInstance Class
	#region Delphox
	public class DelphoxInstance : PokemonInstance
	{
		#region Delphox Constructors
		/// <summary>
		/// Delphox Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DelphoxInstance(string nickname, int level)
		: base(
				655,
				SpeciesDelphox.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delphox Builder only waiting for a Level
		/// </summary>
		public DelphoxInstance(int level)
		: base(
				655,
				SpeciesDelphox.Instance, // PokemonInstance Species
				"Delphox", level,
				Fire.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delphox Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Delphox() : base(
			655,
			SpeciesDelphox.Instance, // PokemonInstance Species
			Fire.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}