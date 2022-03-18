using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Heatmor Species to store common natural stats of all Heatmors
	#region SpeciesHeatmor
	public class SpeciesHeatmor : PokemonSpecies
	{
#nullable enable
		private static SpeciesHeatmor? _instance = null;
#nullable restore
        public static SpeciesHeatmor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHeatmor();
                }
                return _instance;
            }
        }

		#region SpeciesHeatmor Constructor
		public SpeciesHeatmor() : base(
			631,
			"Heatmor",
			1.4,
			58.0,
			85, // HPs
			97, 66, // Attack & Defense
			105, 66, // Special Attack & Defense
			65		
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
				"Cut",
				"Bind",
				"Tackle",
				"Body-Slam",
				"Wrap",
				"Flamethrower",
				"Low-Kick",
				"Solar-Beam",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Double-Team",
				"Lick",
				"Fire-Blast",
				"Amnesia",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Feint-Attack",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Recycle",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Overheat",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Tickle",
				"Aerial-Ace",
				"Fling",
				"Gastro-Acid",
				"Sucker-Punch",
				"Flare-Blitz",
				"Night-Slash",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Bug-Bite",
				"Hone-Claws",
				"Flame-Burst",
				"Round",
				"Incinerate",
				"Inferno",
				"Belch",
				"Confide",
				"Power-Up-Punch",
				"Fire-Lash"
			};
		}
		#endregion
	}
	#endregion

	//Heatmor PokemonInstance Class
	#region Heatmor
	public class HeatmorInstance : PokemonInstance
	{
		#region Heatmor Constructors
		/// <summary>
		/// Heatmor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HeatmorInstance(string nickname, int level)
		: base(
				SpeciesHeatmor.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heatmor Builder only waiting for a Level
		/// </summary>
		public HeatmorInstance(int level)
		: base(
				SpeciesHeatmor.Instance, // PokemonInstance Species
				"Heatmor", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heatmor Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HeatmorInstance() : base(
			SpeciesHeatmor.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}