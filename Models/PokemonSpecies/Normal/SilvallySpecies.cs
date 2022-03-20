using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Silvally Species to store common natural stats of all Silvallys
	#region SilvallySpecies
	public class SilvallySpecies : PokemonSpecies
	{
#nullable enable
		private static SilvallySpecies? _instance = null;
#nullable restore
        public static SilvallySpecies Instance => _instance ?? (_instance = new SilvallySpecies());

		#region SilvallySpecies Constructor
		public SilvallySpecies() : base(
			773,
			"Silvally",
			Normal.Instance,
			2.3,
			100.5,
			new PokemonStats(
				95, // HPs
				95, 95, // Attack & Defense
				95, 95, // Spacial Attack & Defense
				95 // Speed
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
				"Razor-Wind",
				"Swords-Dance",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Roar",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Rage",
				"Double-Team",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Tri-Attack",
				"Substitute",
				"Protect",
				"Scary-Face",
				"Sandstorm",
				"Swagger",
				"Steel-Wing",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Hail",
				"Facade",
				"Imprison",
				"Poison-Fang",
				"Crush-Claw",
				"Metal-Sound",
				"Aerial-Ace",
				"Dragon-Claw",
				"U-Turn",
				"Payback",
				"Heal-Block",
				"Punishment",
				"Air-Slash",
				"X-Scissor",
				"Giga-Impact",
				"Shadow-Claw",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Flash-Cannon",
				"Draco-Meteor",
				"Iron-Head",
				"Double-Hit",
				"Flame-Charge",
				"Round",
				"Water-Pledge",
				"Fire-Pledge",
				"Grass-Pledge",
				"Work-Up",
				"Snarl",
				"Parting-Shot",
				"Confide",
				"Multi-Attack"
			};
		}
		#endregion
	}
	#endregion
}