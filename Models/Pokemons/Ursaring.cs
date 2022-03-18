using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ursaring Species to store common natural stats of all Ursarings
	#region SpeciesUrsaring
	public class SpeciesUrsaring : PokemonSpecies
	{
#nullable enable
		private static SpeciesUrsaring? _instance = null;
#nullable restore
        public static SpeciesUrsaring Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesUrsaring();
                }
                return _instance;
            }
        }

		#region SpeciesUrsaring Constructor
		public SpeciesUrsaring() : base(
			217,
			"Ursaring",
			1.8,
			125.8,
			90, // HPs
			130, 75, // Attack & Defense
			75, 75, // Special Attack & Defense
			55		
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
				"Thrash",
				"Double-Edge",
				"Leer",
				"Roar",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
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
				"Scary-Face",
				"Feint-Attack",
				"Mud-Slap",
				"Zap-Cannon",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Sweet-Scent",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Hammer-Arm",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Last-Resort",
				"Seed-Bomb",
				"Focus-Blast",
				"Giga-Impact",
				"Avalanche",
				"Shadow-Claw",
				"Rock-Climb",
				"Gunk-Shot",
				"Stone-Edge",
				"Captivate",
				"Hone-Claws",
				"Smack-Down",
				"Round",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Play-Nice",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Ursaring PokemonInstance Class
	#region Ursaring
	public class UrsaringInstance : PokemonInstance
	{
		#region Ursaring Constructors
		/// <summary>
		/// Ursaring Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public UrsaringInstance(string nickname, int level)
		: base(
				SpeciesUrsaring.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ursaring Builder only waiting for a Level
		/// </summary>
		public UrsaringInstance(int level)
		: base(
				SpeciesUrsaring.Instance, // PokemonInstance Species
				"Ursaring", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ursaring Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public UrsaringInstance() : base(
			SpeciesUrsaring.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}