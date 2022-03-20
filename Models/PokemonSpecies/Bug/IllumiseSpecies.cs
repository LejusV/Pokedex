using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Illumise Species to store common natural stats of all Illumises
	#region IllumiseSpecies
	public class IllumiseSpecies : PokemonSpecies
	{
#nullable enable
		private static IllumiseSpecies? _instance = null;
#nullable restore
        public static IllumiseSpecies Instance => _instance ?? (_instance = new IllumiseSpecies());

		#region IllumiseSpecies Constructor
		public IllumiseSpecies() : base(
			314,
			"Illumise",
			Bug.Instance,
			0.6,
			17.7,
			new PokemonStats(
				65, // HPs
				47, 75, // Attack & Defense
				73, 85, // Spacial Attack & Defense
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
				"Growth",
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
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Baton-Pass",
				"Encore",
				"Sweet-Scent",
				"Moonlight",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Flatter",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Wish",
				"Brick-Break",
				"Secret-Power",
				"Aromatherapy",
				"Fake-Tears",
				"Air-Cutter",
				"Silver-Wind",
				"Aerial-Ace",
				"Covet",
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
				"Play-Nice",
				"Confide",
				"Dazzling-Gleam",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}