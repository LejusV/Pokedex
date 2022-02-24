using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Grumpig Specie to store common natural stats of every {'abilities': ['thick-fat', 'own-tempo', 'gluttony'], 'base_experience': 165, 'height': 9, 'id': 326, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'psybeam', 'hyper-beam', 'counter', 'seismic-toss', 'thunder-wave', 'toxic', 'psychic', 'mimic', 'double-team', 'confuse-ray', 'light-screen', 'reflect', 'swift', 'dream-eater', 'flash', 'psywave', 'splash', 'rest', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'torment', 'facade', 'focus-punch', 'taunt', 'trick', 'role-play', 'magic-coat', 'recycle', 'brick-break', 'skill-swap', 'snatch', 'secret-power', 'teeter-dance', 'odor-sleuth', 'signal-beam', 'bounce', 'covet', 'calm-mind', 'shock-wave', 'natural-gift', 'payback', 'fling', 'power-gem', 'drain-punch', 'focus-blast', 'energy-ball', 'giga-impact', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'charge-beam', 'psyshock', 'telekinesis', 'round', 'bulldoze', 'belch', 'confide', 'power-up-punch'], 'name': 'grumpig', 'stats': {'hp': 80, 'attack': 45, 'defense': 65, 'special-attack': 90, 'special-defense': 110, 'speed': 80}, 'types': ['psychic'], 'weight': 715, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'purple', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-iii', 'growth_rate': 'fast', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ブーピッグ', 'roomaji': 'Boopig', 'ko': '피그킹', 'zh-Hant': '噗噗豬', 'fr': 'Groret', 'de': 'Groink', 'es': 'Grumpig', 'it': 'Grumpig', 'en': 'Grumpig', 'ja': 'ブーピッグ', 'zh-Hans': '噗噗猪'}, 'genera': {'ja-Hrkt': 'あやつりポケモン', 'ko': '조작포켓몬', 'zh-Hant': '操縱寶可夢', 'fr': 'Pokémon Magouilleur', 'de': 'Manipulator', 'es': 'Pokémon Manipulador', 'it': 'Pokémon Raggiro', 'en': 'Manipulate Pokémon', 'ja': 'あやつりポケモン', 'zh-Hans': '操纵宝可梦'}}
	public class SpecieGrumpig : PokemonSpecie
	{
#nullable enable
		private static SpecieGrumpig? _instance = null;
#nullable restore
        public static SpecieGrumpig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrumpig();
                }
                return _instance;
            }
        }

		public SpecieGrumpig() : base(
			"Grumpig",
			80, // HPs
			45, 65, // Attack & Defense
			90, 110, // Special Attack & Defense
			80			
		) {}
	}


	//Grumpig Pokemon Class
	public class Grumpig : Pokemon
	{

		public Grumpig(string nickname, int level)
		: base(
				326,
				SpecieGrumpig.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Grumpig() : base(
			326,
			SpecieGrumpig.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}