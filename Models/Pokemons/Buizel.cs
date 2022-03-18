using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Buizel Species to store common natural stats of all Buizels
	#region SpeciesBuizel
	public class SpeciesBuizel : PokemonSpecies
	{
#nullable enable
		private static SpeciesBuizel? _instance = null;
#nullable restore
        public static SpeciesBuizel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBuizel();
                }
                return _instance;
            }
        }

		#region SpeciesBuizel Constructor
		public SpeciesBuizel() : base(
			418,
			"Buizel",
			0.7,
			29.5,
			55, // HPs
			65, 35, // Attack & Defense
			60, 30, // Special Attack & Defense
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
				"Double-Slap",
				"Ice-Punch",
				"Razor-Wind",
				"Headbutt",
				"Growl",
				"Sonic-Boom",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Strength",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Waterfall",
				"Swift",
				"Fury-Swipes",
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
				"Baton-Pass",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Bulk-Up",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Me-First",
				"Aqua-Ring",
				"Aqua-Tail",
				"Switcheroo",
				"Captivate",
				"Aqua-Jet",
				"Double-Hit",
				"Soak",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Tail-Slap",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Buizel PokemonInstance Class
	#region Buizel
	public class BuizelInstance : PokemonInstance
	{
		#region Buizel Constructors
		/// <summary>
		/// Buizel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BuizelInstance(string nickname, int level)
		: base(
				SpeciesBuizel.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buizel Builder only waiting for a Level
		/// </summary>
		public BuizelInstance(int level)
		: base(
				SpeciesBuizel.Instance, // PokemonInstance Species
				"Buizel", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buizel Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BuizelInstance() : base(
			SpeciesBuizel.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}