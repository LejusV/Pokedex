using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Volbeat Species to store common natural stats of all Volbeats
	#region VolbeatSpecies
	public class VolbeatSpecies : PokemonSpecies
	{
#nullable enable
		private static VolbeatSpecies? _instance = null;
#nullable restore
        public static VolbeatSpecies Instance => _instance ?? (_instance = new VolbeatSpecies());

		#region VolbeatSpecies Constructor
		public VolbeatSpecies() : base(
			313,
			"Volbeat",
			Bug.Instance,
			0.7,
			17.7,
			new PokemonStats(
				65, // HPs
				73, 75, // Attack & Defense
				47, 85, // Spacial Attack & Defense
				85 // Speed
			)			
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
}