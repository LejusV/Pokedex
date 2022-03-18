using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Moltres Species to store common natural stats of all Moltress
	#region SpeciesMoltres
	public class SpeciesMoltres : PokemonSpecies
	{
#nullable enable
		private static SpeciesMoltres? _instance = null;
#nullable restore
        public static SpeciesMoltres Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMoltres();
                }
                return _instance;
            }
        }

		#region SpeciesMoltres Constructor
		public SpeciesMoltres() : base(
			146,
			"Moltres",
			2.0,
			60.0,
			90, // HPs
			100, 90, // Attack & Defense
			125, 85, // Special Attack & Defense
			90		
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
				"Razor-Wind",
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Peck",
				"Solar-Beam",
				"Fire-Spin",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Secret-Power",
				"Air-Cutter",
				"Overheat",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Air-Slash",
				"Giga-Impact",
				"Defog",
				"Ominous-Wind",
				"Flame-Charge",
				"Round",
				"Sky-Drop",
				"Incinerate",
				"Hurricane",
				"Confide",
				"Burn-Up"
			};
		}
		#endregion
	}
	#endregion

	//Moltres PokemonInstance Class
	#region Moltres
	public class MoltresInstance : PokemonInstance
	{
		#region Moltres Constructors
		/// <summary>
		/// Moltres Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MoltresInstance(string nickname, int level)
		: base(
				SpeciesMoltres.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Moltres Builder only waiting for a Level
		/// </summary>
		public MoltresInstance(int level)
		: base(
				SpeciesMoltres.Instance, // PokemonInstance Species
				"Moltres", level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Moltres Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MoltresInstance() : base(
			SpeciesMoltres.Instance, // PokemonInstance Species
			Fire.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}