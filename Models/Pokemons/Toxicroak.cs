using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Toxicroak Species to store common natural stats of all Toxicroaks
	#region SpeciesToxicroak
	public class SpeciesToxicroak : PokemonSpecies
	{
#nullable enable
		private static SpeciesToxicroak? _instance = null;
#nullable restore
        public static SpeciesToxicroak Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesToxicroak();
                }
                return _instance;
            }
        }

		#region SpeciesToxicroak Constructor
		public SpeciesToxicroak() : base(
			454,
			"Toxicroak",
			1.3,
			44.4,
			83, // HPs
			106, 65, // Attack & Defense
			86, 65, // Special Attack & Defense
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
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Poison-Sting",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Flatter",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Bulk-Up",
				"Bounce",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"X-Scissor",
				"Drain-Punch",
				"Vacuum-Wave",
				"Focus-Blast",
				"Giga-Impact",
				"Nasty-Plot",
				"Mud-Bomb",
				"Rock-Climb",
				"Gunk-Shot",
				"Stone-Edge",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Belch",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Toxicroak PokemonInstance Class
	#region Toxicroak
	public class ToxicroakInstance : PokemonInstance
	{
		#region Toxicroak Constructors
		/// <summary>
		/// Toxicroak Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ToxicroakInstance(string nickname, int level)
		: base(
				SpeciesToxicroak.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxicroak Builder only waiting for a Level
		/// </summary>
		public ToxicroakInstance(int level)
		: base(
				SpeciesToxicroak.Instance, // PokemonInstance Species
				"Toxicroak", level,
				Poison.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxicroak Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ToxicroakInstance() : base(
			SpeciesToxicroak.Instance, // PokemonInstance Species
			Poison.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}