using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Heatmor Species to store common natural stats of all Heatmors
	#region HeatmorSpecies
	public class HeatmorSpecies : PokemonSpecies
	{
#nullable enable
		private static HeatmorSpecies? _instance = null;
#nullable restore
        public static HeatmorSpecies Instance => _instance ?? (_instance = new HeatmorSpecies());

		#region HeatmorSpecies Constructor
		public HeatmorSpecies() : base(
			631,
			"Heatmor",
			Fire.Instance,
			1.4,
			58.0,
			new PokemonStats(
				85, // HPs
				97, 66, // Attack & Defense
				105, 66, // Spacial Attack & Defense
				65 // Speed
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
}