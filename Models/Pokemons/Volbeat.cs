using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Volbeat Species to store common natural stats of all Volbeats
	#region SpeciesVolbeat
	public class SpeciesVolbeat : PokemonSpecies
	{
#nullable enable
		private static SpeciesVolbeat? _instance = null;
#nullable restore
        public static SpeciesVolbeat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVolbeat();
                }
                return _instance;
            }
        }

		#region SpeciesVolbeat Constructor
		public SpeciesVolbeat() : base(
			"Volbeat",
			0.7,
			17.7,
			65, // HPs
			73, 75, // Attack & Defense
			47, 85, // Special Attack & Defense
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
				"Mega-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Counter",
				"Seismic-Toss",
				"Solar-Beam",
				"String-Shot",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Metronome",
				"Swift",
				"Dizzy-Punch",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Baton-Pass",
				"Encore",
				"Moonlight",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Trick",
				"Brick-Break",
				"Secret-Power",
				"Tail-Glow",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Fling",
				"Bug-Buzz",
				"Zen-Headbutt",
				"Captivate",
				"Bug-Bite",
				"Charge-Beam",
				"Ominous-Wind",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Play-Rough",
				"Confide",
				"Dazzling-Gleam",
				"Infestation",
				"Power-Up-Punch",
				"Lunge"
			};
		}
		#endregion
	}
	#endregion

	//Volbeat PokemonInstance Class
	#region Volbeat
	public class VolbeatInstance : PokemonInstance
	{
		#region Volbeat Constructors
		/// <summary>
		/// Volbeat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VolbeatInstance(string nickname, int level)
		: base(
				313,
				SpeciesVolbeat.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volbeat Builder only waiting for a Level
		/// </summary>
		public VolbeatInstance(int level)
		: base(
				313,
				SpeciesVolbeat.Instance, // PokemonInstance Species
				"Volbeat", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volbeat Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Volbeat() : base(
			313,
			SpeciesVolbeat.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}