using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lucario Species to store common natural stats of all Lucarios
	#region SpeciesLucario
	public class SpeciesLucario : PokemonSpecies
	{
#nullable enable
		private static SpeciesLucario? _instance = null;
#nullable restore
        public static SpeciesLucario Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLucario();
                }
                return _instance;
            }
        }

		#region SpeciesLucario Constructor
		public SpeciesLucario() : base(
			"Lucario",
			1.2,
			54.0,
			70, // HPs
			110, 70, // Attack & Defense
			115, 70, // Special Attack & Defense
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
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Headbutt",
				"Roar",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Psychic",
				"Quick-Attack",
				"Double-Team",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Bone-Rush",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Extreme-Speed",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Role-Play",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Iron-Defense",
				"Bulk-Up",
				"Calm-Mind",
				"Water-Pulse",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Payback",
				"Fling",
				"Me-First",
				"Magnet-Rise",
				"Force-Palm",
				"Aura-Sphere",
				"Poison-Jab",
				"Dark-Pulse",
				"Dragon-Pulse",
				"Drain-Punch",
				"Vacuum-Wave",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Hone-Claws",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Heal-Pulse",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch",
				"Laser-Focus"
			};
		}
		#endregion
	}
	#endregion

	//Lucario PokemonInstance Class
	#region Lucario
	public class LucarioInstance : PokemonInstance
	{
		#region Lucario Constructors
		/// <summary>
		/// Lucario Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LucarioInstance(string nickname, int level)
		: base(
				448,
				SpeciesLucario.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lucario Builder only waiting for a Level
		/// </summary>
		public LucarioInstance(int level)
		: base(
				448,
				SpeciesLucario.Instance, // PokemonInstance Species
				"Lucario", level,
				Fighting.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lucario Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Lucario() : base(
			448,
			SpeciesLucario.Instance, // PokemonInstance Species
			Fighting.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}