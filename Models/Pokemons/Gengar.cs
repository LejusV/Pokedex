using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gengar Specie to store common natural stats of every {'abilities': ['cursed-body'], 'base_experience': 225, 'height': 15, 'id': 94, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'mega-drain', 'thunderbolt', 'thunder', 'toxic', 'psychic', 'hypnosis', 'rage', 'night-shade', 'mimic', 'double-team', 'confuse-ray', 'bide', 'metronome', 'self-destruct', 'lick', 'skull-bash', 'dream-eater', 'psywave', 'explosion', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'sludge-bomb', 'zap-cannon', 'destiny-bond', 'icy-wind', 'giga-drain', 'endure', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'dynamic-punch', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'uproar', 'torment', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'trick', 'role-play', 'brick-break', 'knock-off', 'skill-swap', 'snatch', 'secret-power', 'shadow-punch', 'natural-gift', 'payback', 'embargo', 'fling', 'sucker-punch', 'poison-jab', 'dark-pulse', 'drain-punch', 'focus-blast', 'energy-ball', 'giga-impact', 'shadow-claw', 'trick-room', 'captivate', 'ominous-wind', 'wonder-room', 'venoshock', 'telekinesis', 'foul-play', 'round', 'hex', 'confide', 'dazzling-gleam', 'infestation', 'power-up-punch'], 'name': 'gengar', 'stats': {'hp': 60, 'attack': 65, 'defense': 60, 'special-attack': 130, 'special-defense': 75, 'speed': 110}, 'types': ['ghost', 'poison'], 'weight': 405, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'purple', 'shape': 'upright', 'habitat': 'cave', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ゲンガー', 'roomaji': 'Gangar', 'ko': '팬텀', 'zh-Hant': '耿鬼', 'fr': 'Ectoplasma', 'de': 'Gengar', 'es': 'Gengar', 'it': 'Gengar', 'en': 'Gengar', 'ja': 'ゲンガー', 'zh-Hans': '耿鬼'}, 'genera': {'ja-Hrkt': 'シャドーポケモン', 'ko': '그림자포켓몬', 'zh-Hant': '影子寶可夢', 'fr': 'Pokémon Ombre', 'de': 'Schatten', 'es': 'Pokémon Sombra', 'it': 'Pokémon Ombra', 'en': 'Shadow Pokémon', 'ja': 'シャドーポケモン', 'zh-Hans': '影子宝可梦'}}
	public class SpecieGengar : PokemonSpecie
	{
#nullable enable
		private static SpecieGengar? _instance = null;
#nullable restore
        public static SpecieGengar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGengar();
                }
                return _instance;
            }
        }

		public SpecieGengar() : base(
			"Gengar",
			60, // HPs
			65, 60, // Attack & Defense
			130, 75, // Special Attack & Defense
			110			
		) {}
	}


	//Gengar Pokemon Class
	public class Gengar : Pokemon
	{

		public Gengar(string nickname, int level) : base(
			94,
			SpecieGengar.Instance, // Pokemon Specie
			nickname, level,
			Ghost.Instance, Poison.Instance			
		) {}

		public Gengar() : base(
			94,
			SpecieGengar.Instance, // Pokemon Specie
			Ghost.Instance, Poison.Instance			
		) {}
	}
}