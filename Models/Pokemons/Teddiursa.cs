using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Teddiursa Species to store common natural stats of all Teddiursas
	#region SpeciesTeddiursa
	public class SpeciesTeddiursa : PokemonSpecies
	{
#nullable enable
		private static SpeciesTeddiursa? _instance = null;
#nullable restore
        public static SpeciesTeddiursa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTeddiursa();
                }
                return _instance;
            }
        }

		#region SpeciesTeddiursa Constructor
		public SpeciesTeddiursa() : base(
			216,
			"Teddiursa",
			0.6,
			8.8,
			60, // HPs
			80, 50, // Attack & Defense
			50, 50, // Special Attack & Defense
			40		
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
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Roar",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Metronome",
				"Lick",
				"Swift",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Feint-Attack",
				"Belly-Drum",
				"Mud-Slap",
				"Zap-Cannon",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Sweet-Scent",
				"Metal-Claw",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Yawn",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Natural-Gift",
				"Close-Combat",
				"Payback",
				"Fling",
				"Last-Resort",
				"Night-Slash",
				"Seed-Bomb",
				"Shadow-Claw",
				"Gunk-Shot",
				"Captivate",
				"Hone-Claws",
				"Round",
				"Chip-Away",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Play-Rough",
				"Play-Nice",
				"Confide",
				"Baby-Doll-Eyes",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Teddiursa PokemonInstance Class
	#region Teddiursa
	public class TeddiursaInstance : PokemonInstance
	{
		#region Teddiursa Constructors
		/// <summary>
		/// Teddiursa Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TeddiursaInstance(string nickname, int level)
		: base(
				SpeciesTeddiursa.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Teddiursa Builder only waiting for a Level
		/// </summary>
		public TeddiursaInstance(int level)
		: base(
				SpeciesTeddiursa.Instance, // PokemonInstance Species
				"Teddiursa", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Teddiursa Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TeddiursaInstance() : base(
			SpeciesTeddiursa.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}