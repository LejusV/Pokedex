using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Togekiss Species to store common natural stats of all Togekisss
	#region SpeciesTogekiss
	public class SpeciesTogekiss : PokemonSpecies
	{
#nullable enable
		private static SpeciesTogekiss? _instance = null;
#nullable restore
        public static SpeciesTogekiss Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTogekiss();
                }
                return _instance;
            }
        }

		#region SpeciesTogekiss Constructor
		public SpeciesTogekiss() : base(
			"Togekiss",
			1.5,
			38.0,
			85, // HPs
			50, 95, // Attack & Defense
			120, 115, // Special Attack & Defense
			80		
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
				"Headbutt",
				"Flamethrower",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Fire-Blast",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Rollout",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Extreme-Speed",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Heat-Wave",
				"Facade",
				"Focus-Punch",
				"Trick",
				"Magic-Coat",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"Fling",
				"Last-Resort",
				"Aura-Sphere",
				"Air-Slash",
				"Drain-Punch",
				"Giga-Impact",
				"Zen-Headbutt",
				"Defog",
				"Captivate",
				"Grass-Knot",
				"Ominous-Wind",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Togekiss PokemonInstance Class
	#region Togekiss
	public class TogekissInstance : PokemonInstance
	{
		#region Togekiss Constructors
		/// <summary>
		/// Togekiss Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TogekissInstance(string nickname, int level)
		: base(
				468,
				SpeciesTogekiss.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togekiss Builder only waiting for a Level
		/// </summary>
		public TogekissInstance(int level)
		: base(
				468,
				SpeciesTogekiss.Instance, // PokemonInstance Species
				"Togekiss", level,
				Fairy.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togekiss Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Togekiss() : base(
			468,
			SpeciesTogekiss.Instance, // PokemonInstance Species
			Fairy.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}